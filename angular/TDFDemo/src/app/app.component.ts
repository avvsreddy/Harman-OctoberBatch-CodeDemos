import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CreateContactComponent } from './create-contact/create-contact.component';
import { ListContactComponent } from './list-contact/list-contact.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CreateContactComponent,ListContactComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TDFDemo';
}
