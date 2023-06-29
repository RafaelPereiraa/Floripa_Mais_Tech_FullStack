import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.css']
})
export class SearchBarComponent {
  searchText: string = '';

  @Output() searchTextChanged  = new EventEmitter<string>();

  onSearchTextChange() {
    this.searchTextChanged.emit(this.searchText);
  }
}
