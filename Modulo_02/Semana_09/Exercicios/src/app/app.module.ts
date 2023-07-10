import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { HeaderComponent } from './shared/header/header.component';
import { HomeComponent } from './private/home/home.component';
import { SearchBarComponent } from './search-bar/search-bar.component';
import { SearchComponent } from './search/search.component';
import { AboutComponent } from './private/about/about.component';
import { FullComponent } from './full/full.component';
import { ContentComponent } from './layouts/content/content.component';
import { SigninComponent } from './public/signin/signin.component';
import { EsqueciSenhaComponent } from './public/esquecisenha/esquecisenha.component';
import { LoginComponent } from './public/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { NotfoundComponent } from './notfound/notfound.component';
import { PublicoGuard } from './public/public.guards';
import { PrivateGuard } from './private/private.guards';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: SigninComponent, canActivate: [PublicoGuard] },
  { path: 'esqueci-senha', component: EsqueciSenhaComponent, canActivate: [PublicoGuard] },
  {
    path: 'privado',
    canActivate: [PrivateGuard],
    loadChildren: () => import('./private/private.module').then(m => m.PrivateModule)
  }
];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    SearchBarComponent,
    SearchComponent,
    AboutComponent,
    FullComponent,
    ContentComponent,
    SigninComponent,
    EsqueciSenhaComponent,
    LoginComponent,
    NotfoundComponent,
  ],
  imports: [BrowserModule, FormsModule, AppRoutingModule, RouterModule.forRoot(routes), ReactiveFormsModule],
  exports: [RouterModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
