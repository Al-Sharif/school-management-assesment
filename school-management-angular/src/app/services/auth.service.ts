import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { LoginModel, LoginResponseModel } from '../models/login';
import { RegisterModel } from '../models/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private _http:HttpClient) { }
  private controllerUrl = "Authenticate/"
  login(model: LoginModel){
    return this._http.post<LoginResponseModel>(`${environment.baseUrl}${this.controllerUrl}Login`, model);
  }
}
