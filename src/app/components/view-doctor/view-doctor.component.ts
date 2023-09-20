import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IDoctor } from 'src/app/models/doctor.model';

@Component({
  selector: 'app-view-doctor',
  templateUrl: './view-doctor.component.html',
  styleUrls: ['./view-doctor.component.css']
})
export class ViewDoctorComponent {
  doctors:IDoctor[]=[{DoctorId: 1,DoctorName:"John"},{DoctorId: 2,DoctorName:"Alex"},{DoctorId: 3,DoctorName:"Ameer"}];
  constructor( private router:Router){}
  editDoctor(doctor:any){
    this.router.navigate(['/doctor',doctor.DoctorId])
  }
}
