import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { RegisterModel } from '../models/register';
import { RequestViewList } from '../models/request';

@Injectable({
  providedIn: 'root'
})
export class HrService {

  constructor(private _http:HttpClient) { }
  private controllerUrl = "HumanResource/"
  register(model: RegisterModel){
    return this._http.post(`${environment.baseUrl}${this.controllerUrl}AddRequest`, model);
  }

  updateStatus(id: number, approved: boolean){
    return this._http.put(`${environment.baseUrl}${this.controllerUrl}UpdateStatus/${id}/${approved}`, null);
  }

  getPendingRequests(pageSize: number = 10, pageNumber: number = 0){
    return this._http.get<RequestViewList>(`${environment.baseUrl}${this.controllerUrl}PendingRequests/${pageSize}/${pageNumber}`);
  }
}
