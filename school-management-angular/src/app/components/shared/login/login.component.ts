import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { ToastrService } from 'ngx-toastr';
import { UserRoles } from 'src/app/constants/roles';
import { LoginModel } from 'src/app/models/login';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private _authService: AuthService, private _jwtService: JwtHelperService, private _router: Router, private _toastr: ToastrService) { }
  credintials = new LoginModel();
  ngOnInit(): void {
  }
  login(){
    this._authService.login(this.credintials).subscribe(res =>{
      if(res && res.token){
        localStorage.setItem('access_token', res.token);
        let decodedToken = this._jwtService.decodeToken(res.token);
        console.log(decodedToken);
        if(decodedToken.role == UserRoles.Student){
          this._router.navigate(['/']);
        }
        else if (decodedToken.role == UserRoles.Staff){
          this._router.navigate(['/dashboard/staff']);
        }
        else if (decodedToken.role == UserRoles.HumanResource){
          this._router.navigate(['/dashboard/human-resource'])
        }

      }
      else{
        this._toastr.error('Login Failed');
      }
    }, (err) =>{
      this._toastr.error('Login Failed');
    })
  }
}
