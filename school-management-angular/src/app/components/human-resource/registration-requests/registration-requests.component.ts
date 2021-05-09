import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { RequestViewModel } from 'src/app/models/request';
import { HrService } from 'src/app/services/hr.service';

@Component({
  selector: 'app-registration-requests',
  templateUrl: './registration-requests.component.html',
  styleUrls: ['./registration-requests.component.css']
})
export class RegistrationRequestsComponent implements OnInit {

  constructor(private _hrService: HrService, private _toastr: ToastrService) { }
  requests: RequestViewModel[] = [];
  recordsCount = 0;
  totalPages = 0;
  currentPage = 0;
  pageSize = 5;
  ngOnInit(): void {
    this.getData();
  }
  updateStatus(id: number, approved: boolean) {
    this._hrService.updateStatus(id, approved).subscribe(res => {
      if (approved)
        this._toastr.success('Request Approved');
      else
        this._toastr.success('Request Rejected');
      this.getData();
    }, (err) => {
      this._toastr.error(err);
    })
  }
  next() {
    this.currentPage++;
    this.getData();
  }
  prev() {
    this.currentPage--;
    this.getData();
  }
  getData() {
    this._hrService.getPendingRequests(this.pageSize, this.currentPage).subscribe(res => {
      this.requests = res.requests;
      this.recordsCount = res.recordsCount;
      this.totalPages = this.recordsCount / this.pageSize - 1;
    }, (err) => {
      this._toastr.error('Unauthorized Access');
    });
  }
}
