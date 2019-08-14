import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";

import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { ClienteDetalhesComponent } from './cliente-detalhes/cliente-detalhes.component';
import { ClienteDetalheComponent } from './cliente-detalhes/cliente-detalhe/cliente-detalhe.component';
import { ClienteDetalheListaComponent } from './cliente-detalhes/cliente-detalhe-lista/cliente-detalhe-lista.component';
import { ClienteDetalheService } from './compartilhado/cliente-detalhe.service';

@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsComponent,
    ClienteDetalhesComponent,
    ClienteDetalheComponent,
    ClienteDetalheListaComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [ClienteDetalheService],
  bootstrap: [AppComponent]
})
export class AppModule { }
