import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotificationFooterComponent } from './notification-footer.component';

describe('NotificationFooterComponent', () => {
  let component: NotificationFooterComponent;
  let fixture: ComponentFixture<NotificationFooterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NotificationFooterComponent]
    });
    fixture = TestBed.createComponent(NotificationFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
