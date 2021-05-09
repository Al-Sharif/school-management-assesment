import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistrationRequestsComponent } from './components/human-resource/registration-requests/registration-requests.component';
import { HomeComponent } from './components/shared/home/home.component';
import { DashboardLayoutComponent } from './components/shared/layouts/dashboard-layout/dashboard-layout.component';
import { HomeLayoutComponent } from './components/shared/layouts/home-layout/home-layout.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { StudentsListComponent } from './components/staff/students-list/students-list.component';
import { CanActivateHumanResource } from './guards/human-resource.guard';
import { CanActivateStaff } from './guards/staff.guard';

const routes: Routes = [
  {
    path: '',
    component: HomeLayoutComponent,
    children: [
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ]
  },
  {
    path: 'dashboard',
    component: DashboardLayoutComponent,
    children: [
      { path: 'staff', component: StudentsListComponent, canActivate: [CanActivateStaff] },
      { path: 'human-resource', component: RegistrationRequestsComponent, canActivate: [CanActivateHumanResource] }
    ]
  },
  //no layout routes
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
