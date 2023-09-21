import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { IDoctor } from 'src/app/models/doctor.model';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-view-doctor',
  templateUrl: './view-doctor.component.html',
  styleUrls: ['./view-doctor.component.css']
})
export class ViewDoctorComponent {
  doctors:IDoctor[]=[];
  //{DoctorId: 1,DoctorName:"John"},{DoctorId: 2,DoctorName:"Alex"},{DoctorId: 3,DoctorName:"Ameer"}
  constructor(private http:DataService, private router:Router){}
  ngOnInit(){
    this.http.getAllDoctors().subscribe((data) => {  
      console.log(data);
      this.doctors=data;
  }); 
  }
  editDoctor(doctor:any){
    this.router.navigate(['/doctor',doctor.doctorId])
  }
}
