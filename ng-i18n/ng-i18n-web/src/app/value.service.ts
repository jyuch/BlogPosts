import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import { Value } from './value';

const valuesUrl = '/api/values';

@Injectable({
  providedIn: 'root'
})
export class ValueService {

  constructor(
    private http: HttpClient
  ) { }

  getValue(): Observable<Value> {
    return this.http.get<Value>(valuesUrl);
  }
}
