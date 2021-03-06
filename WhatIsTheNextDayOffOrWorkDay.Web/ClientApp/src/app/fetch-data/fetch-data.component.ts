import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public periodos: Periodo[];
  public pessoa: Pessoa;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Pessoa>(baseUrl + 'api/pessoas/1').subscribe(result => {
      this.pessoa = result;
    }, error => console.error(error));

    http.get<Periodo[]>(baseUrl + 'api/pessoas/periodo?id=1&range=20').subscribe(result => {
      this.periodos = result;
    }, error => console.error(error));
  }
}

interface Periodo {
  data: string;
  indicador: string;
}

interface Pessoa {
  apelido: string;
  email: string;
}
