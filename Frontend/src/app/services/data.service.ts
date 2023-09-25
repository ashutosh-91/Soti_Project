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
   
  //Change the port Number Whoever is running The Backend ~AS 

    
    // return this.http.get<IDoctor[]>('https://localhost:7170/api/Doctor');
    return this.http.get<IDoctor[]>('https://localhost:44396/api/Doctor');

  }
  deleteDoctor(doctor: any):any{
   
    return this.http.delete('https://localhost:44396/api/Doctor/'+doctor);
  }
  updateDoctor(doctor: any):any{
    return this.http.put('https://localhost:7170/api/Doctor',doctor);
  }
  addDoctor(doctor:any):any{
    return this.http.post('https://localhost:7170/api/Doctor',doctor);
  }
  getAllSpecializations():Observable<ISpecialization[]>{
    return this.http.get<ISpecialization[]>('https://localhost:44396/api/Specialization');
  }
  getAllSurgeries():any{
    return this.http.get('https://localhost:7170/api/Surgery');
  }
  updateSurgery(surgery:any):any{
    return this.http.put('https://localhost:7170/api/Surgery',surgery);
  }
  getDoctorSpecialization(specializationCode :any):any{
    return this.http.get('https://localhost:44396/api/DoctorSpecialization/'+specializationCode);
  }

}
