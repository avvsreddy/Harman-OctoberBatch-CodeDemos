import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
onSubmit() {
//console.log(this.contactForm);
// call api for taking suitable action

// TODO
// custom validators
// dynamic controlls

}
  title = 'ReactiveFormsDemo';
  contactForm:FormGroup = new FormGroup(
    {
      name : new FormControl('',[Validators.required,Validators.minLength(3)]),
      email: new FormControl('', [Validators.required,Validators.email]),
      mobile:new FormControl('',Validators.required),
      location: new FormControl('Bangalore',Validators.required),
      dob: new FormControl(''),
      gender: new FormControl('',Validators.required)
    });





}
