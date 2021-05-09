import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RegisterModel } from 'src/app/models/register';
import { AuthService } from 'src/app/services/auth.service';
import { HrService } from 'src/app/services/hr.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private _hrService: HrService, private _router: Router, private _toastr: ToastrService) { }
  student = new RegisterModel();
  ngOnInit(): void {
  }
  register(){
    this._hrService.register(this.student).subscribe(res =>{
      this._router.navigate(['/login']);
      this._toastr.success('Waiting approval from human resource', 'Registration request submitted');

    }, (err) =>{
      this._toastr.error(err);
    })
  }
}
