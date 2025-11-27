import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-usuario-register',
  templateUrl: './usuario-register.component.html',
  styleUrls: ['./usuario-register.component.css']
})
export class UsuarioRegisterComponent {
  constructor(private router: Router) { }

  pacienteRegister() {
    this.router.navigate(['/register-paciente']);
  }

  profesionalRegister() {
    this.router.navigate(['/register-profesional']);
  }
}
