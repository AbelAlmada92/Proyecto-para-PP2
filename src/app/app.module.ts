import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SeleccionUsuarioComponent } from './seleccion-usuario/seleccion-usuario.component';
import { ProfesionalLoginComponent } from './profesional-login/profesional-login.component';
import { PacienteLoginComponent } from './paciente-login/paciente-login.component';
import { UsuarioRegisterComponent } from './usuario-register/usuario-register.component';
import { RegisterPacienteComponent } from './register-paciente/register-paciente.component';
import { RegisterProfesionalComponent } from './register-profesional/register-profesional.component'; 

import { HistorialComponent } from './historial/historial.component';

import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    SeleccionUsuarioComponent,
    ProfesionalLoginComponent,
    PacienteLoginComponent,
    UsuarioRegisterComponent,
    RegisterPacienteComponent,
    RegisterProfesionalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HistorialComponent,
     FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
