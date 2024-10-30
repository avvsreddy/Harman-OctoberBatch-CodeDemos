import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CategoryCreateComponent } from './category-create/category-create.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { ArticleSubmitComponent } from './article-submit/article-submit.component';
import { ArticleReviewComponent } from './article-review/article-review.component';
import { ArticleBrowseComponent } from './article-browse/article-browse.component';
import { UsersListComponent } from './users-list/users-list.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { NotFoundComponent } from './not-found/not-found.component';

export const routes: Routes = 
[
    {
        path:'',
        redirectTo:'home',
        pathMatch:'full'
    },
    {
        path:'home',
        component:HomeComponent,
        title:'Knowledge Hub Portal - Home'
    },
    {
        path:'category-create',
        component:CategoryCreateComponent,
        title:'Knowledge Hub Portal - Create Category'
    },
    {
        path:'category-list',
        component:CategoryListComponent,
         title:'Knowledge Hub Portal - List Category'
    },
    {
        path:'article-submit',
        component:ArticleSubmitComponent,
         title:'Knowledge Hub Portal - Submit Article'
    },
    {
        path:'article-review',
        component:ArticleReviewComponent,
         title:'Knowledge Hub Portal - Review Articles'
    },
    {
        path:'article-browse',
        component:ArticleBrowseComponent,
         title:'Knowledge Hub Portal - Browse Articles '
    },
    {
        path:'users-list',
        component:UsersListComponent,
         title:'Knowledge Hub Portal - Users List'
    },
    {
        path:'register',
        component:RegisterComponent,
         title:'Knowledge Hub Portal - Register'
    },
    {
        path:'login',
        component:LoginComponent,
         title:'Knowledge Hub Portal - Login'
    },
    {
        path:'**',
        component:NotFoundComponent,
         title:'Knowledge Hub Portal'
    }
];
