////import { Injectable, Inject } from '@angular/core';
////import { HttpClient, HttpHeaders } from '@angular/common/http';
////import { Observable } from 'rxjs';
////import { Periodo } from '../../model/periodo';
////import { error } from 'console';
////@Injectable({
////  providedIn: 'root'
////})
////export class PessoaService {
////  private baseUrl: string;
////  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl : string) {
////    this.baseUrl = baseUrl
////  }
////  public Initialize(){
////    const headers = new HttpHeaders().set('content-type', 'application/json');
////    this.http.get<Periodo>(this.baseUrl + 'api/pessoas/periodo?id=1&range=7', { headers }).subscribe(
////      result =>
////    {
////    }, error =>
////    {
////      console.error(error)
////    });
////  }
////}
//# sourceMappingURL=pessoa.service.js.map