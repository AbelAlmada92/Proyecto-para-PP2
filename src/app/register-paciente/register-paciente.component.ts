import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register-paciente',
  templateUrl: './register-paciente.component.html',
  styleUrls: ['./register-paciente.component.css']
})
export class RegisterPacienteComponent {

  constructor(private router: Router) {}

  crearCuenta() {
    // acá más adelante guardás los datos del paciente...
    // por ahora solo navegamos al historial

    this.router.navigate(['/historial']);
  }
}
