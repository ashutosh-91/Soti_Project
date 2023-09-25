import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ISpecialization } from 'src/app/models/specialization.model';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-view-specialization',
  templateUrl: './view-specialization.component.html',
  styleUrls: ['./view-specialization.component.css']
})

export class ViewSpecializationComponent {
  specializations: ISpecialization[]=[];
  ngOnInit(){
    this.http.getAllSpecializations().subscribe((data) => {  
      console.log(data);
      this.specializations=data;
  }); 
  }

  constructor(private http:DataService, private router:Router){}
  viewDoctor(specialization:any){
    console.log(specialization);
    this.router.navigate(['/specialization',specialization.specializationCode])
  }
}
