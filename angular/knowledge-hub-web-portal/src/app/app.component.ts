import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { CategoryCreateComponent } from './category-create/category-create.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { ArticleBrowseComponent } from './article-browse/article-browse.component';
import { ArticleReviewComponent } from './article-review/article-review.component';
import { ArticleSubmitComponent } from './article-submit/article-submit.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { UsersListComponent } from './users-list/users-list.component';
import { NotFoundComponent } from './not-found/not-found.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,HomeComponent,NavbarComponent,FooterComponent,CategoryCreateComponent,CategoryListComponent,ArticleBrowseComponent,ArticleReviewComponent,ArticleSubmitComponent,LoginComponent,RegisterComponent,UsersListComponent,NotFoundComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'knowledge-hub-web-portal';
}
