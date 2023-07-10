import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class PublicoGuard implements CanActivate {

  constructor(private router: Router) {}

  canActivate(): boolean {
    const userEmail = localStorage.getItem('email');
    if (!userEmail) {
      return true;
    } else {
      this.router.navigate(['/home']);
      return false;
    }
  }
}
