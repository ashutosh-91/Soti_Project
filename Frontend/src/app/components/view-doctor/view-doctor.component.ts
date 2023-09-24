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
  showMsgDiv:string ='';
  couldFetch:boolean=false;
  deleteMsg:boolean=false;
  ngOnInit(){
    this.http.getAllDoctors().subscribe((data) => {  
      // console.log(data);
      this.doctors=data;
     
        
      if(data.length>0){
        
        this.showMsgDiv="All Doctors Fetched Successfully!!!";
        this.couldFetch=!this.couldFetch;
        
      }
      else{
        this.showMsgDiv="No Doctors Present !!!";
        this.couldFetch=false;
      
      }
      
  }); 
  }

 




  
  constructor(private http:DataService, private router:Router){}
  editDoctor(doctor:any){
    this.router.navigate(['/doctor',doctor.doctorId])
  }

//Created the httpdelete and Updated Data
  deleteDoctor(doctor:Number){
    // console.log(typeof(doctor))
       this.http.deleteDoctor(doctor).subscribe((data:any)=>{
         this.deleteMsg=data;
         this.http.getAllDoctors().subscribe((data:any)=>{
          this.doctors=data;
         });
        
        //  console.log(data)
       })
  }
}
