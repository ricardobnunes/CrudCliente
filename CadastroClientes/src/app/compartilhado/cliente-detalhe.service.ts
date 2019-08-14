import { Injectable } from '@angular/core';
import { ClienteDetalhe } from './cliente-detalhe.model';

@Injectable({
  providedIn: 'root'
})
export class ClienteDetalheService {

  formData:ClienteDetalhe
  
  constructor() { }
}
