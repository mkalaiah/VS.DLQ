<<<<<<< HEAD
﻿import { NgModule } from '@angular/core';
=======
import { NgModule } from '@angular/core';
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from "app/roles/roles.component";

<<<<<<< HEAD
=======
import { QuestionComponent } from '@app/question/question.component';
import { ReportIllegalComponent } from '@app/reportillegal/report-illegal-activities.component';

>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AppComponent,
                children: [
                    { path: 'home', component: HomeComponent,  canActivate: [AppRouteGuard] },
                    { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' }, canActivate: [AppRouteGuard] },
                    { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, canActivate: [AppRouteGuard] },
                    { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, canActivate: [AppRouteGuard] },
<<<<<<< HEAD
                    { path: 'about', component: AboutComponent }
=======
                    { path: 'about', component: AboutComponent },
                    { path: 'question', component: QuestionComponent, canActivate: [AppRouteGuard] },
                    { path: 'illegal', component: ReportIllegalComponent, canActivate: [AppRouteGuard] }
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
<<<<<<< HEAD
export class AppRoutingModule { }
=======
export class AppRoutingModule { }
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
