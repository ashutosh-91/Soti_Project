import { Component } from '@angular/core';

@Component({
  selector: 'app-add-doctor',
  templateUrl: './add-doctor.component.html',
  styleUrls: ['./add-doctor.component.css']
})
export class AddDoctorComponent {
  message: string = '';

  displayMessage(){
    this.message = 'Doctor successfully added'
  }

}
