import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IDoctor } from '../models/doctor.model';
import { ISpecialization } from '../models/specialization.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http:HttpClient) { }
  getAllDoctors():Observable<IDoctor[]>{
    return this.http.get<IDoctor[]>('https://localhost:7170/api/Doctor');
  }
  updateDoctor(doctor: any):any{
    return this.http.put('https://localhost:7170/api/Doctor',doctor);
  }
  addDoctor(doctor:any):any{
    return this.http.post('https://localhost:7170/api/Doctor',doctor);
  }
  getAllSpecializations():Observable<ISpecialization[]>{
    return this.http.get<ISpecialization[]>('https://localhost:7170/api/Specialization');
  }
  getAllSurgeries():any{
    return this.http.get('https://localhost:7170/api/Surgery');
  }
  updateSurgery(surgery:any):any{
    return this.http.put('https://localhost:7170/api/Surgery',surgery);
  }

}
