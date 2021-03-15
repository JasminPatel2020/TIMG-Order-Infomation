import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { OrderInfoService } from '../../services/orderitem.service';

@Component({
    selector: 'orderinfo',
    templateUrl: './orderinfo.component.html'
})
export class OrderInfoComponent {
   
    public orderInformation: OrderItemInfo[];
    public cacheorderInformation: OrderItemInfo[];
    public clientNameSummaries: CLients[];

    constructor(public http: Http, @Inject('BASE_URL') baseUrl: string, private _orderInfoService: OrderInfoService) {
        this.getOrderInfo();
        this.getClientNames();
    }


    getOrderInfo() {
        this._orderInfoService.getOrderinfo().subscribe(
            (data: any) => {
                console.log(data);
                this.orderInformation = data;
                this.cacheorderInformation = data;
            }
        );
    }
    getClientNames() {
        this._orderInfoService.getClientNames().subscribe(
            (data: any) => {
                console.log(data);
                this.clientNameSummaries = data;
            }
        );
    }

    filterByClientName(filterVal: any) {
        if (filterVal == "0")
            this.orderInformation = this.cacheorderInformation;
        else
            this.orderInformation = this.cacheorderInformation.filter((item) => item.clientName == filterVal);
    }
}

interface OrderItemInfo {
    clientId: number;
    clientName: string;
    orderDate: string;
    gst: number;
    total: number;
    productCode: string;
    quantity: number;
    totalPrice: number;
}
interface CLients {
    name: string;
}
