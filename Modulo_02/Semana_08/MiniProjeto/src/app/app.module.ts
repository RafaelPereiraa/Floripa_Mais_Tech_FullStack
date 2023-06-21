import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NotificationListComponent } from './notification-list/notification-list.component';
import { NotificationItemComponent } from './notification-item/notification-item.component';
import { NotificationHeaderComponent } from './notification-header/notification-header.component';
import { NotificationFooterComponent } from './notification-footer/notification-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    NotificationListComponent,
    NotificationItemComponent,
    NotificationHeaderComponent,
    NotificationFooterComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
