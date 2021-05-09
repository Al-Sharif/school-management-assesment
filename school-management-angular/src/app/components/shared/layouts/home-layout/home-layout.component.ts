import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-home-layout',
  templateUrl: './home-layout.component.html',
  styleUrls: ['./home-layout.component.css']
})
export class HomeLayoutComponent implements OnInit {
  currentUser: any;

  constructor(private _router: Router, private _jwtService: JwtHelperService) { }

  ngOnInit(): void {
    this.currentUser = this._jwtService.decodeToken();
  }
  signOut(){
    localStorage.removeItem('access_token');
    this._router.navigate(['/login']);
  }
}
