import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SeleccionUsuarioComponent } from './seleccion-usuario/seleccion-usuario.component';
import { ProfesionalLoginComponent } from './profesional-login/profesional-login.component';
import { PacienteLoginComponent } from './paciente-login/paciente-login.component';
import { UsuarioRegisterComponent } from './usuario-register/usuario-register.component';
import { RegisterPacienteComponent } from './register-paciente/register-paciente.component';
import { RegisterProfesionalComponent } from './register-profesional/register-profesional.component';
const routes: Routes = [
  { path: '', component: SeleccionUsuarioComponent },
  { path: 'profesional-login', component: ProfesionalLoginComponent },
  { path: 'paciente-login', component: PacienteLoginComponent },
  { path: 'usuario-register', component: UsuarioRegisterComponent },
  { path: 'register-paciente', component: RegisterPacienteComponent },
  { path: 'register-profesional', component: RegisterProfesionalComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
