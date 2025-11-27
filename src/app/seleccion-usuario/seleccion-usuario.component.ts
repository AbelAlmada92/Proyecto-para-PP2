import { Component } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-seleccion-usuario',
  templateUrl: './seleccion-usuario.component.html',
  styleUrls: ['./seleccion-usuario.component.css']
})
export class SeleccionUsuarioComponent {

  seleccionTipoUsuario: string = '';

  constructor(private router: Router) { }


  seleccionUsuario(userType: string) {
    this.seleccionTipoUsuario = userType;
    console.log('Usuario seleccionado:', userType);
    
    if (userType=== 'profesional') {
      this.router.navigate(['/profesional-login']);
    }
    else{
      this.router.navigate(['/paciente-login']);
    }
  }

  register(){
    this.router.navigate(['/usuario-register']);
  }
}
