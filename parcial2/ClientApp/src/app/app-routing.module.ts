import { TerceroRegistroComponent } from './Parcial2/tercero-registro/tercero-registro.component';
import { TerceroConsultaComponent } from './Parcial2/tercero-consulta/tercero-consulta.component';
import { PagoConsultaComponent } from './Parcial2/pago-consulta/pago-consulta.component';
import { PagoRegistroComponent } from './Parcial2/pago-registro/pago-registro.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { from } from 'rxjs';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
  path: 'terceroRegistro',
  component: TerceroRegistroComponent
  },
  {
  path: 'terceroConsulta',
  component: TerceroConsultaComponent
  },
  {
  path: 'pagoRegistro',
  component: PagoRegistroComponent
  },
  {
  path: 'pagoConsulta',
  component: PagoConsultaComponent
  }
  ];
  

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
