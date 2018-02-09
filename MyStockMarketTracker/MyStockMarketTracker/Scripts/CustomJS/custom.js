function LoadDayChart(companySymbol) {
    var symbolData = companySymbol;
    var ourRequest = new XMLHttpRequest();
    ourRequest.open('GET', 'https://api.iextrading.com/1.0/stock/' + symbolData + '/chart/1d');
    ourRequest.onload = function () {
        var ourData = JSON.parse(ourRequest.responseText);
        //console.log(ourData);
        var dataArray = [];
        var datesArry = [];
        var holdAverage;
        for (i = 0; i < ourData.length; i++) {
            if (ourData[i].average > 0) {
                dataArray.push(ourData[i].average);
                holdAverage = ourData[i].average;
            }
            else {
                dataArray.push(holdAverage);
            }

            datesArry.push(ourData[i].label);
        }
        fillChartDay(dataArray, datesArry);
    };
    ourRequest.send();
}
function LoadPastChart(companySymbol) {
    var symbolData = companySymbol;
    var ourRequest = new XMLHttpRequest();
    ourRequest.open('GET', 'https://api.iextrading.com/1.0/stock/' + symbolData + '/chart/1m');
    ourRequest.onload = function () {
        var ourData = JSON.parse(ourRequest.responseText);
        //console.log(ourData);
        var highArray = [];
        var lowArray = [];
        var datesArry = [];
        var holdHigh;
        var holdLow;
        for (i = 0; i < ourData.length; i++) {
            if (ourData[i].high > 0) {
                highArray.push(ourData[i].high);
                holdHigh = ourData[i].high;
            }
            else {
                highArray.push(holdHigh);
            }

            if (ourData[i].low > 0) {
                lowArray.push(ourData[i].low);
                holdLow = ourData[i].low;
            }
            else {
                lowArray.push(holdLow);
            }

            datesArry.push(ourData[i].date);
        }
        fillPastChart(highArray, lowArray, datesArry);
    };
    ourRequest.send();
}

function fillChartDay(data, data2) {
    var ctx = document.getElementById("dayChart").getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'line',
        scaleOverride: true,
        data: {
            labels: data2,
            datasets: [{
                label: 'Average',
                fill: false,
                lineTention: 0.1,
                data: data,
                backgroundColor: 'rgba(0, 100, 0,1)',
                borderColor: 'rgba(0, 100, 0,1)',
                borderWidth: 2,
                spanGaps: true
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Day Average'
            },
            elements: {
                point: {
                    radius: 0,
                    hoverRadius: 8,
                    hitRadius: 4
                }
            },
            scales: {
                xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        stepSize: 5
                    },
                    ticks: {
                        scaleBeginAtZero: true,
                        autoSkip: true,
                        maxTicksLimit: 10,
                        minTicksLimit: 1
                    }
                }],
                yAxes: [{
                    display: true,
                    ticks: {
                        scaleBeginAtZero: false,
                        autoSkip: true,
                        maxTicksLimit: 15,
                        minTicksLimit: 1
                    }
                }]
            }
        }
    });
}
function fillPastChart(high, low, labels) {
    var ctxHigh = document.getElementById("pastChartHigh").getContext('2d');
    var myChartHigh = new Chart(ctxHigh, {
        type: 'line',
        scaleOverride: true,
        data: {
            labels: labels,
            datasets: [{
                label: 'High',
                fill: false,
                lineTention: 0.1,
                data: high,
                backgroundColor: 'rgba(255, 99, 132, 0.2)',
                borderColor: 'rgba(255,99,132,1)',
                borderWidth: 2
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Month High'
            },
            elements: {
                point: {
                    radius: 0,
                    hoverRadius: 10,
                    hitRadius: 10
                }
            },
            scales: {
                xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        stepSize: 5
                    },
                    ticks: {
                        scaleBeginAtZero: true,
                        autoSkip: true,
                        maxTicksLimit: 15
                    }
                }],
                yAxes: [{
                    display: true,
                    ticks: {
                        scaleBeginAtZero: false,
                        autoSkip: true,
                        maxTicksLimit: 15
                    }
                }]
            }
        }
    });

    var ctxLow = document.getElementById("pastChartLow").getContext('2d');
    var myChartLow = new Chart(ctxLow, {
        type: 'line',
        scaleOverride: true,
        data: {
            labels: labels,
            datasets: [{
                label: 'Low',
                fill: false,
                lineTention: 0.1,
                data: low,
                backgroundColor: 'rgba(255, 99, 132, 0.2)',
                borderColor: 'rgba(255,99,132,1)',
                borderWidth: 2
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Month Low'
            },
            elements: {
                point: {
                    radius: 0,
                    hoverRadius: 10,
                    hitRadius: 10
                }
            },
            scales: {
                xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        stepSize: 5
                    },
                    ticks: {
                        scaleBeginAtZero: true,
                        autoSkip: true,
                        maxTicksLimit: 15
                    }
                }],
                yAxes: [{
                    display: true,
                    ticks: {
                        scaleBeginAtZero: false,
                        autoSkip: true,
                        maxTicksLimit: 15
                    }
                }]
            }
        }
    });

    var ctxHighLow = document.getElementById("pastChartLowHigh").getContext('2d');
    var myChartLowHigh = new Chart(ctxHighLow, {
        type: 'line',
        scaleOverride: true,
        data: {
            labels: labels,
            datasets: [{
                label: 'High',
                fill: false,
                lineTention: 0.1,
                data: high,
                backgroundColor: 'rgba(0, 100, 0,1)',
                borderColor: 'rgba(0, 100, 0,1)',
                borderWidth: 2,
                spanGaps: true,
                pointBorderColor: "black",
                pointBackgroundColor: "white"
            }, {
                label: 'Low',
                fill: false,
                lineTention: 0.1,
                data: low,
                backgroundColor: 'rgba(139, 0, 0, 1)',
                borderColor: 'rgba(139, 0, 0, 1)',
                borderWidth: 2,
                spanGaps: true,
                pointBorderColor: "black",
                pointBackgroundColor: "white"
            }
            ]
        },
        options: {
            title: {
                display: true,
                text: 'Month High'
            },
            elements: {
                point: {
                    radius: 2.,
                    hoverRadius: 8,
                    hitRadius: 4
                }
            },
            scales: {
                xAxes: [{
                    display: true,
                    scaleLabel: {
                        display: true,
                        stepSize: 5
                    },
                    ticks: {
                        autoSkip: true,
                        maxTicksLimit: 15
                    }
                }],
                yAxes: [{
                    display: true,
                    ticks: {
                        autoSkip: false,
                        maxTicksLimit: 15,
                        beginAtZero: false
                    }
                }]
            }
        }
    });
}

//var btn = document.getElementById("btn");

//btn.addEventListener("click", function () {
//    var ourRequest = new XMLHttpRequest();
//    ourRequest.open('GET', 'https://api.iextrading.com/1.0/stock/aapl/chart/1y')
//    ourRequest.onload = function () {
//        var ourData = JSON.parse(ourRequest.responseText);
//        var dataArray = [];
//        var dataArray2 = [];
//        var datesArry = [];
//        for (i = 0; i < ourData.length; i++) {
//            dataArray.push(ourData[i].high);
//            dataArray2.push(ourData[i].low);
//            datesArry.push(ourData[i].date);
//            //datesArry.push(ourData[i].minute);
//        }
//        loadChart(dataArray, datesArry);
//    };
//    ourRequest.send();
//});

//var animalContainer = document.getElementById("animal-info")
//var btn = document.getElementById("btn");

//btn.addEventListener("click", function () {
//    var ourRequest = new XMLHttpRequest();
//    ourRequest.open('GET', 'https://learnwebcode.github.io/json-example/animals-1.json')
//    ourRequest.onload = function () {
//        var ourData = JSON.parse(ourRequest.responseText);
//        renderHTML(ourData);
//    };
//    ourRequest.send();
//});

//function renderHTML(data) {
//    var htmlString = "";

//    for (i = 0; i < data.length; i++) {
//        htmlString += "<p>" + data[i].date + " is a " + data[i].low + ".</p>"
//    }

//    animalContainer.insertAdjacentHTML('beforeend', htmlString)
//}