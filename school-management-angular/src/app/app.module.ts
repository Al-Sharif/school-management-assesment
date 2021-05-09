import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/shared/login/login.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { StudentsListComponent } from './components/staff/students-list/students-list.component';
import { RegistrationRequestsComponent } from './components/human-resource/registration-requests/registration-requests.component';
import { HomeComponent } from './components/shared/home/home.component';
import { HomeLayoutComponent } from './components/shared/layouts/home-layout/home-layout.component';
import { DashboardLayoutComponent } from './components/shared/layouts/dashboard-layout/dashboard-layout.component';
import { FormsModule } from '@angular/forms';
import { AuthService } from './services/auth.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ContentTypeHeader as ContentTypeInterceptor } from './interceptors/content-type.interceptor';
import { JwtInterceptor, JwtModule } from '@auth0/angular-jwt';
import { ToastrModule } from 'ngx-toastr';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TokenInterceptor } from './interceptors/token.interceptor';
import { CanActivateStaff } from './guards/staff.guard';
import { CanActivateHumanResource } from './guards/human-resource.guard';
export function tokenGetter() {
  return localStorage.getItem("access_token");
}
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    StudentsListComponent,
    RegistrationRequestsComponent,
    HomeComponent,
    HomeLayoutComponent,
    DashboardLayoutComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter
      },
    }),
  ],
  providers: [
    { provide: LocationStrategy, useClass: HashLocationStrategy },
    { provide: HTTP_INTERCEPTORS, useClass: ContentTypeInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    AuthService,
    CanActivateStaff,
    CanActivateHumanResource
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
