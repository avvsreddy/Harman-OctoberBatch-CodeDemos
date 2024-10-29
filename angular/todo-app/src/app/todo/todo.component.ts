import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './todo.component.html',
  styleUrl: './todo.component.css'
})
export class TodoComponent {
todoItems:string[]=[];
todoItem:string='';


addItem()
{
  this.todoItems.push(this.todoItem);
  this.todoItem='';
}

removeItem(index:number)
{
  this.todoItems.splice(index,1);
}

}
