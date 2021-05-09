import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { UserViewModel } from '../models/register';

@Injectable({
  providedIn: 'root'
})
export class StaffService {

  constructor(private _http: HttpClient) { }
  private controllerUrl = "Staff/"
  getStudents(){
    return this._http.get<UserViewModel[]>(`${environment.baseUrl}${this.controllerUrl}Students`);
  }
}
