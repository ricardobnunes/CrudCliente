import { Component, OnInit } from '@angular/core';
import { ClienteDetalheService } from 'src/app/compartilhado/cliente-detalhe.service';

@Component({
  selector: 'app-cliente-detalhe',
  templateUrl: './cliente-detalhe.component.html',
  styles: []
})
export class ClienteDetalheComponent implements OnInit {

  constructor(private service:ClienteDetalheService) { }

  ngOnInit() {
  }

}
