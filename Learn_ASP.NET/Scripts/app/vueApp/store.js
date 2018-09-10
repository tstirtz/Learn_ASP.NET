const store = {
    data: {
        expenses:[
          {
            name: "Coffee",
            amount: "3.50",
            category: "coffee"
          },
          {
            name: "lunch",
            amount: "8.00",
            category: "restaurant"
          }
        ]
    },
    methods: {
        total(){
        let total = 0;

        store.data.expenses.forEach((currentItem, index) => {
            let cents = currentItem.amount * 100;
            total += cents;
        });

        let totalDollars = total / 100;
        let totalWithCents = totalDollars.toFixed(2);

        return totalWithCents;
        },
        clearTableAction(){
            console.log(store.data.expenses);
            store.data.expenses = [];
            console.log(store.data.expenses);
        }
    }
}

export default store;
