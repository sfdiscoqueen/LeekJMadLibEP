// Jasmine Leek
// 26oct2022
// MadLib - Endpoints
// This is a webapi application that tells a funny short story using url inputs
// peer review: Isaiah Ferguson - Great Program and an amazing story! super Unique!!

using Microsoft.AspNetCore.Mvc;

namespace LeekJMadLibEP.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("Story/{noun1}/{noun2}/{noun3}/{num1}/{adj1}/{adv1}/{verb1}/{adj2}/{adj3}/{adj4}")]

    public string FirstNoun(string noun1, string noun2, string noun3, string num1, string adj1, string adv1, string verb1, string adj2, string adj3, string adj4)
    {
        return $"Your MadLib Story\n \nIn a far away town, there lived a unique couple: the {noun1} and the {noun2}. \nOne day, while returning home to the {noun3} after a long day's work, they found {num1} magic beans. \nThe {noun1} was so {adj1} and told the {noun2} they needed to {adv1} {verb1} back home! \nThe magic beans would disappear overnight if they weren't planted. \nAccording to legend, the {noun1} said, each bean would grant them a single wish, and they had {num1} wishes in store. \nThe {noun2} looked {adj2}, and then got to work preparing the soil to plant each of the {num1} magic beans. \nOnce it was time to plant the first magic bean, the {noun1} asked the {noun2} what their first wish would be. \nThe {noun2} replied: 'The time has finally come! I wish for a {adj3}, {adj4} shovel! \nThe {noun1} laughed and they lived happily ever after! \nTHE END!";
    }

}




