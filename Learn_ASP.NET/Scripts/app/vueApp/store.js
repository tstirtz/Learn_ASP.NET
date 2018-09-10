const store = {
    data: {
        expenses:[
          {
            name: "Coffee",
            amount: "3.50",
            category: "coffee"
          },
          {
            name: "Lunch",
            amount: "8.00",
            category: "restaurants"
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
        },
        getCategoryTotal(categoryName){
            const categoryExpenses = store.data.expenses.filter(expense => expense.category === categoryName);
            let categoryTotal = 0;
            categoryExpenses.forEach(expense => {
                let amountInCents = parseInt(expense.amount);
                categoryTotal += amountInCents;
            });
            return categoryTotal;
        },
        generateChart(){
            google.charts.load("current", {packages:["corechart"]});
              google.charts.setOnLoadCallback(drawChart);
              function drawChart() {
                var data = google.visualization.arrayToDataTable([
                  ['Task', 'Hours per Day'],
                  ['Coffee', store.methods.getCategoryTotal('coffee')],
                  ['Car', store.methods.getCategoryTotal('car')],
                  ['Groceries', store.methods.getCategoryTotal('groceries')],
                  ['Rent', store.methods.getCategoryTotal('rent')],
                  ['Restaurants', store.methods.getCategoryTotal('restaurants')],
                  ['Misc', store.methods.getCategoryTotal('misc')]
                ]);

                var options = {
                  is3D: true,
                };
                var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
                    chart.draw(data, options);
              }
        }
    }
}

export default store;
