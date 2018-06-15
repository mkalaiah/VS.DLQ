import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from "app/roles/roles.component";
import { QuestionComponent } from '@app/question/question.component';
import { ReportIllegalComponent } from '@app/reportillegal/reportillegalactivities.component';
import { ReportIssueComponent } from '@app/reportissue/reportissue.component';
import { RulesComponent } from '@app/rules/rules.component';
import { SpeciesComponent } from '@app/species/species.component';

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
                    { path: 'about', component: AboutComponent },
                    { path: 'question', component: QuestionComponent },
                    { path: 'reportillegal', component: ReportIllegalComponent },
                    { path: 'reportissue', component: ReportIssueComponent },
                    { path: 'rules', component: RulesComponent },
                    { path: 'species', component: SpeciesComponent }
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
