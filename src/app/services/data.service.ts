import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IDoctor } from '../models/doctor.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http:HttpClient) { }
  getAllDoctors():Observable<IDoctor[]>{
    return this.http.get<IDoctor[]>('https://localhost:7170/api/Doctor');
  }
}
