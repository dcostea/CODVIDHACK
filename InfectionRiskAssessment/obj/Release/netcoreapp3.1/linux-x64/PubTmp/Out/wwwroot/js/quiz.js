var quiz = {
    "CompleteFor": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "WasInDangerZone": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "LivesWithMedic": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "HasContactWithPacients": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "HasGeneralHealthIssues": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "IsMedical": {
        type: "radio",
        value: null,
        number: 1,
        isRequired: true
    },
    "BirthYear": {
        type: "input",
        value: 0,
        number: 2,
        isRequired: false
    },
    "Height": {
        type: "input",
        value: null,
        number: 3,
        isRequired: false
    },
    "Weight": {
        type: "input",
        value: null,
        number: 4,
        isRequired: false
    },
    "Place": {
        type: "radio",
        value: null,
        number: 5,
        isRequired: true
    },
    "County": {
        type: "input",
        value: null,
        number: 6,
        isRequired: false
    },
    "IsIsolated": {
        type: "input",
        value: null,
        number: 7,
        isRequired: true
    },
    "Sex": {
        type: "radio",
        value: null,
        number: 8,
        isRequired: true
    },
    "IsPregnant": {
        type: "radio",
        value: 1,
        number: 9,
        isRequired: true,
        conditions: [{
            property: "Sex",
            value: 1
        }]
    },
    "HasContact": {
        type: "radio",
        value: null,
        number: 10,
        isRequired: true
    },
    "DaysAfterContact": {
        type: "radio",
        value: null,
        number: 11,
        isRequired: true
    },
    "WasTested": {
        type: "radio",
        value: null,
        number: 12,
        isRequired: true
    },
    "IsPositive": {
        type: "radio",
        value: null,
        number: 13,
        isRequired: true
    },
    "InfectedAndNotTested": {
        type: "radio",
        value: null,
        number: 14,
        isRequired: true
    },
    "PresentState": {
        type: "radio",
        value: null,
        number: 15,
        isRequired: true
    },
    "HasFever": {
        type: "radio",
        value: null,
        number: 16,
        isRequired: true
    },
    "CanMeasureFeverTemperature": {
        type: "radio",
        value: null,
        number: 16,
        isRequired: true
    },
    "FeverTemperature": {
        type: "input",
        value: 0,
        number: 17,
        isRequired: false
    },
    "IsCoughing": {
        type: "radio",
        value: null,
        number: 18,
        isRequired: true
    },
    "IsTired": {
        type: "radio",
        value: null,
        number: 19,
        isRequired: true
    },
    "HasHeadache": {
        type: "radio",
        value: null,
        number: 20,
        isRequired: true
    },
    "CanBreathNormally": {
        type: "radio",
        value: null,
        number: 21,
        isRequired: true
    },
    "HasSoreThroath": {
        type: "radio",
        value: null,
        number: 22,
        isRequired: true
    },
    "IsHoarse": {
        type: "radio",
        value: null,
        number: 23,
        isRequired: true
    },
    "CanSmell": {
        type: "radio",
        value: null,
        number: 24,
        isRequired: true
    },
    "CanTaste": {
        type: "radio",
        value: null,
        number: 25,
        isRequired: true
    },
    "HasDiarrhea": {
        type: "radio",
        value: null,
        number: 26,
        isRequired: true
    },
    "HasChestPain": {
        type: "radio",
        value: null,
        number: 27,
        isRequired: true
    },
    "HasStomachAche": {
        type: "radio",
        value: null,
        number: 28,
        isRequired: true
    },
    "HasMusclePain": {
        type: "radio",
        value: null,
        number: 29,
        isRequired: true
    },
    "IsConfused": {
        type: "radio",
        value: null,
        number: 30,
        isRequired: true
    },
    "HasAppetite": {
        type: "radio",
        value: null,
        number: 31,
        isRequired: true
    },
    "HasOtherIssues": {
        type: "radio",
        value: null,
        number: 32,
        isRequired: true
    },
    "OtherIssues": {
        type: "input",
        value: "",
        number: 32,
        isRequired: true
    },
    "HasHealthIssues": {
        type: "radio",
        value: null,
        number: 33,
        isRequired: false
    },
    "NeedsHelp": {
        type: "radio",
        value: null,
        number: 34,
        isRequired: true
    },
    "HasHelp": {
        type: "radio",
        value: null,
        number: 35,
        isRequired: true
    },
    "UsesWheelchair": {
        type: "radio",
        value: null,
        number: 36,
        isRequired: true
    },
    "HasIssuesThatLimtActivity": {
        type: "radio",
        value: null,
        number: 37,
        isRequired: true
    },
    "HasCardioVascularIssues": {
        type: "radio",
        value: null,
        number: 38,
        isRequired: true
    },
    "UsesBloodPressurePills": {
        type: "radio",
        value: null,
        number: 39,
        isRequired: true
    },
    "UsesAspirin": {
        type: "radio",
        value: null,
        number: 40,
        isRequired: true
    },
    "HasDiabetes": {
        type: "radio",
        value: null,
        number: 41,
        isRequired: true
    },
    "HasLungIssues": {
        type: "radio",
        value: null,
        number: 42,
        isRequired: true
    },
    "IsSmoking": {
        type: "radio",
        value: null,
        number: 43,
        isRequired: true
    },
    "HasLiverIssues": {
        type: "radio",
        value: null,
        number: 44,
        isRequired: true
    },
    "HasKidneyIssues": {
        type: "radio",
        value: null,
        number: 45,
        isRequired: true
    },
    "IsDoingDialysis": {
        type: "radio",
        value: null,
        number: 46,
        isRequired: true
    },
    "HasCancer": {
        type: "radio",
        value: null,
        number: 47,
        isRequired: true
    },
    "UsesImmunosuppressivePills": {
        type: "radio",
        value: null,
        number: 48,
        isRequired: true
    },
    "UsesAntiInflammatoryPills": {
        type: "radio",
        value: null,
        number: 49,
        isRequired: true
    },
    "HasTwin": {
        type: "radio",
        value: null,
        number: 50,
        isRequired: true
    },
    "PlaceNow": {
        type: "radio",
        value: null,
        number: 51,
        isRequired: true
    },
    "WillReccomand": {
        type: "input",
        value: null,
        number: 52,
        isRequired: true
    },
    "AgreesContact": {
        type: "radio",
        value: null,
        number: 51,
        isRequired: true
    },
    "Email": {
        type: "input",
        value: null,
        number: 52,
        isRequired: true
    }
};

var minQuestion = 1;
var maxQuestion = 59;
var currentQuestion = 1;
var nextQuestion = document.getElementById("next-question");
var previousQuestion = document.getElementById("previous-question");
var submitBtn = document.getElementById("submit-btn");
var progressBar = document.getElementById("progress-bar");


$(function() {

    previousQuestion.style.display = "none";
    submitBtn.style.display = "none";

    let currentQuestions = document.querySelectorAll("[data-question-number]");
    console.log(currentQuestions);
    currentQuestions.forEach(question => {
        if(parseInt(question.getAttribute("data-question-number")) === currentQuestion) {
            question.classList.remove('question-hidden');
        } 
    });


    Object.keys(quiz).forEach(function(quizQuestion) {
        let quizNodes = document.getElementsByName(quizQuestion);
        quizNodes.forEach(function(node) {
            node.addEventListener('change', function() {
                console.log(this.name, this.value);
                quiz[this.name].value = this.value;
            })
        });
    });

    nextQuestion.addEventListener('click', function() {
        let currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0];        
        let currentQuestions = document.querySelectorAll("[data-question-number");
        currentQuestions.forEach(question => {
            question.classList.add('question-hidden');
        });
        previousQuestion.style.display = "inline-block";
        if(currentQuestion >= maxQuestion) return;
        while(true) {
            currentQuestion++;
            currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0]; 
            if(currentSelectedQuestion.hasAttribute("data-condition-prop") && currentSelectedQuestion.hasAttribute("data-condition-value")) {
                let conditionProperty = currentSelectedQuestion.getAttribute("data-condition-prop");
                let conditionValue = currentSelectedQuestion.getAttribute("data-condition-value");
                if(quiz[conditionProperty].value === conditionValue) { 
                    break;
                } else {
                    continue;
                    // currentSelectedQuestion++;
                    // currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0];
                }
            } else {
                currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0]; 
                break;
            }
        }

        currentSelectedQuestion.classList.remove('question-hidden');
        
        if(currentQuestion === maxQuestion) {
            nextQuestion.style.display = "none";
            submitBtn.style.display = "inline-block";
        };

        calculateProgress();

        console.log(currentQuestions);
    });

    previousQuestion.addEventListener('click', function() {
        let currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0];        
        let currentQuestions = document.querySelectorAll("[data-question-number");
        currentQuestions.forEach(question => {
            question.classList.add('question-hidden');
        });

        nextQuestion.style.display = "inline-block";
        if(currentQuestion <= minQuestion) return;

        
        while(true) {
            currentQuestion--;
            currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0]; 
            if(currentSelectedQuestion.hasAttribute("data-condition-prop") && currentSelectedQuestion.hasAttribute("data-condition-value")) {
                let conditionProperty = currentSelectedQuestion.getAttribute("data-condition-prop");
                let conditionValue = currentSelectedQuestion.getAttribute("data-condition-value");
                if(quiz[conditionProperty].value === conditionValue) { 
                    break;
                } else {
                    continue;
                    // currentSelectedQuestion++;
                    // currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0];
                }
            } else {
                currentSelectedQuestion = document.querySelectorAll("[data-question-number='" + currentQuestion + "']")[0]; 
                break;
            }
        }

        currentSelectedQuestion.classList.remove('question-hidden');

        if(currentQuestion === minQuestion) {
            previousQuestion.style.display = "none";
        };

        calculateProgress();
        // console.log(currentQuestions);
        // currentQuestions.forEach(question => {
        //     if(parseInt(question.getAttribute("data-question-number")) === currentQuestion) {
        //         question.classList.remove('question-hidden');
        //     } else {
        //         if (!question.classList.contains('question-hidden')) {
        //             question.classList.add('question-hidden')
        //         }
        //     }
        // });
    });


    submitBtn.addEventListener('click', handleSubmit);


});


function calculateProgress() {
    var progress = parseInt(currentQuestion / maxQuestion * 100);
    progressBar.style.width = progress + "%";
    progressBar.setAttribute("aria-valuenow", progress);
    progressBar.innerText = progress + "%";
}

function handleSubmit() {
    var keys = Object.keys(quiz);
    var quizAnswers = {};
    console.log(quiz);
    keys.forEach(key => {
        console.log(quiz[key]);
        switch (quiz[key].type) {
            case "radio":
                let radioBtns = document.getElementsByName(key);
                radioBtns.forEach(function(radioBtn) {
                    if(radioBtn.checked) {
                        quizAnswers[key] = radioBtn.value;
                    }
                });
                break;
            case "input":
                var input = document.getElementsByName(key)[0];
                var value = input.value;
                var numericValue = parseInt(value);
                var isNumericValue = typeof numericValue === "number" && !isNaN(numericValue);
             
                quizAnswers[key] = isNumericValue ? numericValue : value;
                break;
            default:
                throw new Error("Unkown question type: " + quiz[key].type);
        }
    });

    sendRequest(quizAnswers);


    console.log(quizAnswers);
}

function checkAnswers(answers) {

    var errors = [];

    quiz.forEach(question => {

    });
    
}


function sendRequest(data) {
    if(!data.BirthYear) {
        data.BirthYear = 0;
    }
    if(!data.FeverTemperature) {
        data.FeverTemperature = 0;
    }
    if(!data.OtherIssues) {
        data.OtherIssues = 0;
    }
    fetch('https://helloworldforubuntu.azurewebsites.net/api/Readings/predict', {
        method: 'POST',
        body: JSON.stringify(data),
        headers: {
            "Content-type": "application/json"
        }
    })
    .then(response => response.json())
    .then(json =>  {
        console.log('sad', json)
        let result = json.score[1];
        
        // window.location.href = "http://127.0.0.1:5501/InfectionRiskAssessment/wwwroot/result.html?risk=" + result;
        window.location.href = "https://helloworldforubuntu.azurewebsites.net/response.html?risk=" + result;

    })
    .catch(err => {
        console.log(err);
    })


    // $.ajax({
    //     type: "POST",
    //     url: "https://helloworldforubuntu.azurewebsites.net/api/Readings/predict",
    //     data: {
    //         "respondentId": 0,
    //             "isMedical": 0,
    //             "birthYear": 0,
    //             "height": 0,
    //             "weight": 0,
    //             "place": 0,
    //             "county": "string",
    //             "isIsolated": 0,
    //             "sex": 0,
    //             "isPregnant": 0,
    //             "hasContact": 0,
    //             "daysAfterContact": 0,
    //             "wasTested": 0,
    //             "isPositive": 0,
    //             "infectedAndNotTested": 0,
    //             "presentState": 0,
    //             "hasFever": 0,
    //             "feverTemperature": 0,
    //             "isCoughing": 0,
    //             "isTired": 0,
    //             "hasHeadache": 0,
    //             "canBreathNormally": 0,
    //             "hasSoreThroath": 0,
    //             "isHoarse": 0,
    //             "canSmell": 0,
    //             "canTaste": 0,
    //             "hasDiarrhea": 0,
    //             "hasChestPain": 0,
    //             "hasStomachAche": 0,
    //             "hasMusclePain": 0,
    //             "isConfused": 0,
    //             "hasAppetite": 0,
    //             "otherIssues": 0,
    //             "hasHealthIssues": 0,
    //             "needsHelp": 0,
    //             "hasHelp": 0,
    //             "usesWheelchair": 0,
    //             "hasIssuesThatLimtActivity": 0,
    //             "hasCardioVascularIssues": 0,
    //             "usesBloodPressurePills": 0,
    //             "usesAspirin": 0,
    //             "hasDiabetes": 0,
    //             "hasLungIssues": 0,
    //             "isSmoking": 0,
    //             "hasLiverIssues": 0,
    //             "hasKidneyIssues": 0,
    //             "isDoingDialysis": 0,
    //             "hasCancer": 0,
    //             "usesImmunosuppressivePills": 0,
    //             "usesAntiInflammatoryPills": 0,
    //             "hasTwin": 0,
    //             "placeNow": 0,
    //             "willReccomand": 0,
    //             "agreesContact": 0,
    //             "email": "string"
    //     },
    //     crossDomain: true,
    //     success: function(data) {
    //         console.log(data)
    //     },
    //     dataType: "json"
    //   });

}

// document.addEventListener("DOMContentLoaded", function() {
//     var bts = document.getElementById('bts');
//     bts.addEventListener('click', function(e) {
//         e.preventDefault();
//         var keys = Object.keys(quiz);
//         console.log(quiz);
//         keys.forEach(key => {
//             console.log(quiz[key]);
//             switch (quiz[key].type) {
//                 case "radio":
//                     let radioBtns = document.getElementsByName(key);
//                     console.log("radio");
//                     // console.log(radioBtns);
//                     radioBtns.forEach(function(radioBtn) {
//                         if(radioBtn.checked) {
//                             quiz[key].value = radioBtn.value;
//                         }
//                     });
//                     break;
//                 case "input":
//                     let input = document.getElementsByName(key)[0];
//                     // quiz[key].value = input.value;
//                     console.log("input");
//                     // console.log(input);
//                     break;
//                 default:
//                     throw new Error("Unkown question type: " + quiz[key].type);
//             }
//         });
//     })

// });
