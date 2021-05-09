import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { Observable } from "rxjs";
import { UserRoles } from "../constants/roles";

@Injectable()
export class CanActivateStaff implements CanActivate {
    constructor(private jwtService: JwtHelperService) { }

    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot
    ): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        const hasStaffRole = this.jwtService.decodeToken()?.role == UserRoles.Staff;
        return hasStaffRole;
    }
}