import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IDoctor } from 'src/app/models/doctor.model';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-view-doctor',
  templateUrl: './view-doctor.component.html',
  styleUrls: ['./view-doctor.component.css']
})
export class ViewDoctorComponent {
  doctors:IDoctor[]=[];
  temp:IDoctor[]=[];
  category:any;
  constructor(private http:DataService, private router:Router,private activatedRoute:ActivatedRoute){
    this.category=this.activatedRoute.snapshot.paramMap.get('specializationCode');
    
  }
   ngOnInit(){

   
  if(this.category==null){
    this.http.getAllDoctors().subscribe((data:any) => {  
      console.log(data);
      this.doctors=data;
  }); 
    console.log("cate "+this.category);
    this.doctors=this.temp;
    console.log("temp "+this.temp);

  }
  else{
    console.log("else "+this.category);
  }
  }
  
  editDoctor(doctor:any){
    this.router.navigate(['/doctor',doctor.doctorId])
  }
}
