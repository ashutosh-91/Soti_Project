import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ISpecialization } from 'src/app/models/specialization.model';

@Component({
  selector: 'app-view-specialization',
  templateUrl: './view-specialization.component.html',
  styleUrls: ['./view-specialization.component.css']
})
export class ViewSpecializationComponent {
  specializations:ISpecialization[]=[{SpecializationCode: 1,SpecializationName:"John"},{SpecializationCode: 2,SpecializationName:"Alex"},{SpecializationCode: 3,SpecializationName:"Ameer"}];
  constructor( private router:Router){}
  editspecialization(doctor:any){
    this.router.navigate(['/doctors',doctor.SpecializationCode])
  }
}
