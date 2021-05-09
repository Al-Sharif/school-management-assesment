export class LoginModel{
    email: string = '';
    password: string = '';
}
export class LoginResponseModel{
    token: string = '';
    expiration?: Date;
}