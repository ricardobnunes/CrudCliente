import { Component, OnInit } from '@angular/core';
import { ClienteDetalheService } from 'src/app/compartilhado/cliente-detalhe.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-cliente-detalhe',
  templateUrl: './cliente-detalhe.component.html',
  styles: []
})
export class ClienteDetalheComponent implements OnInit {

  constructor(private service:ClienteDetalheService) { }

  ngOnInit() {
    this.resetForm();

  }

  resetForm(form?: NgForm){
    if(form!=null)
      form.resetForm();
      this.service.formData = {
          ClienteId :0,
          NomeCompleto :'',
          ClienteCod :'',
          TelCliente :'',
          ClienteCPF :'string',
          ClienteRG :'string'
    }

  }

}
