import { Component } from '@angular/core';
import { Contact } from '../../models/contact';
import { FormsModule, NgForm } from '@angular/forms';
import { JsonPipe } from '@angular/common';

@Component({
  selector: 'app-create-contact',
  standalone: true,
  imports: [FormsModule,JsonPipe],
  templateUrl: './create-contact.component.html',
  styleUrl: './create-contact.component.css'
})
export class CreateContactComponent {
onFormSubmit() {
  
// send this contact info to api
// store the contact into into localstorage
localStorage.setItem("contacts",  JSON.stringify(this.contact))
alert("contact saved");
}
contact:Contact=
{
  name:'',
  email:'',
  mobile:'',
  dob:'',
  location:'',
  gender:''
};
}
