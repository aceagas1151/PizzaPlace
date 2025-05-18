export interface Pizza {
  id: string;
  pizzaTypeId: string;
  size: string;
  price: number;
}

export interface OrderDetail {
  id: number;
  orderId: number;
  pizzaId: string;
  quantity: number;
  pizza: Pizza;
}

export interface Order {
  id: number;
  orderDate: string;
  orderDetails: OrderDetail[];
}
