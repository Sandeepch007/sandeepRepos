import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SampleService {
url='https://localhost:7097/api/Product'
  constructor(private http:HttpClient) { }
  getpro(){
    return this.http.get(this.url);
  }
}
