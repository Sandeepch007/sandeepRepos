import { Component, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import { CommonModule, isPlatformBrowser } from '@angular/common';
import { AgGridAngular } from 'ag-grid-angular'; 
import type { ColDef } from 'ag-grid-community';

import { SampleService } from './sample.service';
import { Product } from './Models/product';
import { AllCommunityModule, ModuleRegistry } from 'ag-grid-community'; 


// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [AgGridAngular, CommonModule], 
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']  
})
export class AppComponent implements OnInit {
  title = 'AgGridAngular';
  prolist: Product[] = [];
  coldefs: ColDef<Product>[]=[
    { field: 'productId', headerName: 'Product Id', width: 100 },
      { field: 'productName', headerName: 'Product Name', width: 100 },
      { field: 'proDescription', headerName: 'Description', width: 100 },
      { field: 'price', headerName: 'Price', width: 100 },
      { field: 'quantity', headerName: 'Quantity', width: 100 },
      { field: 'createdAt', headerName: 'Created At', width: 150 }
  ];

  

  isBrowser: boolean;
  AgGridModule: any;

  constructor(@Inject(PLATFORM_ID) private platformId: object,private samp:SampleService) {
    this.isBrowser = isPlatformBrowser(this.platformId);
  }

  

  async ngOnInit(): Promise<void> {
    
    if (this.isBrowser) {
      const { AgGridAngular } = await import('ag-grid-angular');
      this.AgGridModule = AgGridAngular;
    }


    this.samp.getpro().subscribe((data:any) => {  
      this.prolist = data;
    });
  }
  
}
