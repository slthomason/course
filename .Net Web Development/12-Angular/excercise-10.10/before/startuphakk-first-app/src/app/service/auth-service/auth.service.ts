import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private isLoggedIn: boolean = false;
  constructor() { }

  Login() {
    this.isLoggedIn = true;
  }
  Logout() {
    this.isLoggedIn = false;
  }

  IsUserLogined(){
    return this.isLoggedIn;
  }
}
