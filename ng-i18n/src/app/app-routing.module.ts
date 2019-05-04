import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HogeComponent } from './hoge/hoge.component';
import { FugaComponent } from './fuga/fuga.component';

const routes: Routes = [
  { path: '', redirectTo: 'hoge', pathMatch: 'full' },
  { path: 'hoge', component: HogeComponent },
  { path: 'fuga', component: FugaComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }