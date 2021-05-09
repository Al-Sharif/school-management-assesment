import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-dashboard-layout',
  templateUrl: './dashboard-layout.component.html',
  styleUrls: ['./dashboard-layout.component.css']
})
export class DashboardLayoutComponent implements OnInit {

  constructor(private _router: Router, private _jwtService: JwtHelperService) { }
  currentUser = this._jwtService.decodeToken();
  ngOnInit(): void {
  }
  signOut(){
    localStorage.removeItem('access_token');
    this._router.navigate(['/login']);
  }
}
