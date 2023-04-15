using EnglishLearningApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;
using EnglishLearningApp.DTO;
using System.Web;

namespace EnglishLearningApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task Signingoogle()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                RedirectUri = Url.Action("GoogleResponse")
            });
        }

        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new Root
            {
                issuer = claim.Issuer,
                originalIssuer = claim.OriginalIssuer,
                type = claim.Type,
                value = claim.Value
            }).ToList();
            foreach (var i in claims)
            {
                string k = i.value;
            }

            string email = claims.SingleOrDefault(x => x.type.Contains("emailaddress")).value;
            string username = claims[1].value;
            string fullname = claims.SingleOrDefault(x => x.type.Contains("givenname")).value;
            Account acc = new Account(fullname, true, email, "", "DefaultValue", "000000", 2, true);
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var exist = learningEnglishContext.Accounts.SingleOrDefault(x => x.Email.Equals(email));
            if (exist != null)
            {
                var username1 = JsonConvert.SerializeObject(acc.FullName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                var userId = Newtonsoft.Json.JsonConvert.SerializeObject(exist.Id);
                HttpContext.Session.SetString("username", username1);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                HttpContext.Session.SetString("userId", userId);
                return RedirectToAction("Index");
            }
            else
            {
                learningEnglishContext.Accounts.Add(acc);
                learningEnglishContext.SaveChanges();
                var username2 = JsonConvert.SerializeObject(acc.FullName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                var userId = Newtonsoft.Json.JsonConvert.SerializeObject(acc.Id);
                HttpContext.Session.SetString("username", username2);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                HttpContext.Session.SetString("userId", userId);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Index(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = learningEnglishContext.Levels.ToList();
            ViewBag.Active = "5";
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();

            return View(data);
        }

        public IActionResult EnrollLevel(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            string? userId = HttpContext.Session.GetString("userId");
            string userId1 = JsonConvert.DeserializeObject<string>(userId);

            var list1 =
                 (from i in learningEnglishContext.Lessons
                  join j in learningEnglishContext.Parts on i.PartId equals j.Id
                  join l in learningEnglishContext.Levels on i.LevelId equals l.Id
                  where i.LevelId == id
                  select new
                  {
                      Id = i.Id,
                      Lesson = i.Lesson1,
                      Image = i.Image,
                      Part = j.PartName,
                      Level = l.Level1
                  }).ToList();

            List<LessonDTO> list = new List<LessonDTO>();
            foreach (var i in list1)
            {
                var pass = learningEnglishContext
                    .PassLevels.SingleOrDefault(x => x.AccountId == Convert.ToInt32(userId1) && x.LessonId == i.Id);
                if (pass != null)
                {
                    if (pass.Status == true)
                    {
                        list.Add(new LessonDTO(i.Id, i.Lesson, i.Part, i.Level, i.Image, true));
                    }
                    else if (pass.Status == false)
                    {
                        list.Add(new LessonDTO(i.Id, i.Lesson, i.Part, i.Level, i.Image, false));
                    }
                }
                else if (pass == null)
                {
                    list.Add(new LessonDTO(i.Id, i.Lesson, i.Part, i.Level, i.Image, null));
                }
            }
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.lessonId = id;
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();

            return View(data);
        }

        public IActionResult ViewLesson(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list =
            (from i in learningEnglishContext.Lessons
             join j in learningEnglishContext.VocabInLessons on i.Id equals j.LessonId
             where i.Id == id
             select new VocabInLesson { Id = i.Id, Image = j.Image, Word = j.Word, Pronunciation = j.Pronunciation, Meaning = j.Meaning }).ToList();

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.lessonId = id;
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();

            return View(data);
        }

        public IActionResult TestLesson(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = (from j in learningEnglishContext.Questions
                        where j.LessonId == id
                        select j).ToList();
            var list1 = (from j in learningEnglishContext.Answers
                         select j).ToList();
            //ViewBag.LessonId = id;
            foreach (var i in list)
            {
                var x = i.Answers;
            }
            var lessonId = Newtonsoft.Json.JsonConvert.SerializeObject(id);
            HttpContext.Session.SetString("lessonId", lessonId);
            return View(list);
        }

        public IActionResult Mark(IFormCollection iformCollection)
        {

            Account account = new Account();
            string? account1 = HttpContext.Session.GetString("act");

            account = JsonConvert.DeserializeObject<Account>(account1);

            string? id = HttpContext.Session.GetString("lessonId");
            string lessonId = JsonConvert.DeserializeObject<string>(id);

            string? userId = HttpContext.Session.GetString("userId");
            string userId1 = JsonConvert.DeserializeObject<string>(userId);


            int score = 0;
            string[] questionId = iformCollection["questionId"];
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            foreach (var i in questionId)
            {
                int idAnswerCorrect = learningEnglishContext.Answers.Where(a => a.Correct == true && a.QuestionId == Convert.ToInt32(i)).FirstOrDefault().Id;
                if (idAnswerCorrect == Convert.ToInt32(iformCollection["question_" + i]))
                {
                    score++;
                }
            }

            var available = learningEnglishContext.PassLevels
                .SingleOrDefault(x => x.AccountId == Convert.ToInt32(userId1) && x.LessonId == Convert.ToInt32(lessonId));

            if (available != null)
            {
                available.Status = score >= 5 ? true : false;
                learningEnglishContext.SaveChanges();
            }
            else
            {
                PassLevel passLevel = new PassLevel();
                passLevel.AccountId = Convert.ToInt32(userId1);
                passLevel.LessonId = Convert.ToInt32(lessonId);
                passLevel.Status = score >= 5 ? true : false;
                learningEnglishContext.PassLevels.Add(passLevel);
                learningEnglishContext.SaveChanges();
            }
            ViewBag.score = score;
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult DoSignup(Account account)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var acc = learningEnglishContext.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email));
            if (acc == null)
            {
                account.FullName = "Jackson";
                account.Password = EncodePassword(account.Password);
                account.RoleId = 2;
                account.Status = true;
                account.Gender = true;
                account.ContactNo = "0971858758";
                account.UserName = "van5";
                learningEnglishContext.Accounts.Add(account);
                learningEnglishContext.SaveChanges();
                var username = JsonConvert.SerializeObject(account.UserName);
                var role = JsonConvert.SerializeObject(account.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }

        public IActionResult DoLogin(Account account)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();

            var acc = learningEnglishContext.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email) && (x.Password).Equals(account.Password));
            if (acc != null)
            {
                var username = JsonConvert.SerializeObject(acc.UserName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.NoAccount = "Account is not exist";
                return RedirectToAction("Login");
            }
        }

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodePassword(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        public IActionResult SentenceStructure(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentence = (from sc in learningEnglishContext.SentenceStructures
                                join lesson in learningEnglishContext.Lessons on sc.LessonId equals lesson.Id
                                select new
                                {
                                    Id = sc.Id,
                                    Lesson = lesson.Lesson1,
                                    Sentence = sc.Sentence
                                }
                           ).ToList();

            List<SentenceStructureDTO> list = new List<SentenceStructureDTO>();
            foreach (var i in listSentence)
            {
                list.Add(new SentenceStructureDTO(i.Id, i.Lesson, i.Sentence));
            }

            ViewBag.Active = "7";
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult SentenceStructureManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentence = (from sc in learningEnglishContext.SentenceStructures
                                join lesson in learningEnglishContext.Lessons on sc.LessonId equals lesson.Id
                                select new
                                {
                                    Id = sc.Id,
                                    Lesson = lesson.Lesson1,
                                    LessonId = lesson.Id,
                                    Sentence = sc.Sentence
                                }
                           ).ToList();

            List<SentenceStructureDTO> list = new List<SentenceStructureDTO>();
            foreach (var i in listSentence)
            {
                list.Add(new SentenceStructureDTO(i.Id, i.Lesson, i.LessonId, i.Sentence));
            }

            ViewBag.Active = "8";
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult SentenceStructureDelete(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var sentence = learningEnglishContext.SentenceStructures.SingleOrDefault(x => x.Id == id);
            if (sentence != null)
            {
                learningEnglishContext.SentenceStructures.Remove(sentence);
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("SentenceStructureManagement");
        }

        public IActionResult AddNewSentence()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Lesson = learningEnglishContext.Lessons.ToList();
            return View();
        }

        public IActionResult DoAddSentence(SentenceStructure sentence)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            sentence.Level = "Default";
            learningEnglishContext.SentenceStructures.Add(sentence);
            learningEnglishContext.SaveChanges();
            return View();
        }

        public IActionResult AccountManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listAcc = learningEnglishContext.Accounts.ToList();
            ViewBag.Active = "1";
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 2;
            int start = (int)(page - 1) * limit;
            int total = listAcc.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = listAcc.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult UpdateAccount(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var acc = learningEnglishContext.Accounts.SingleOrDefault(x => x.Id == id);
            if (acc != null)
            {
                if (acc.Status == true)
                {
                    acc.Status = false;
                    learningEnglishContext.SaveChanges();
                }
                else
                {
                    acc.Status = true;
                    learningEnglishContext.SaveChanges();
                }
            }
            return RedirectToAction("AccountManagement");
        }

        public IActionResult LessonManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listLesson = (from lesson in learningEnglishContext.Lessons
                              join part in learningEnglishContext.Parts on lesson.PartId equals part.Id
                              join level in learningEnglishContext.Levels on lesson.LevelId equals level.Id
                              select new
                              {
                                  Id = lesson.Id,
                                  Lesson = lesson.Lesson1,
                                  Part = part.PartName,
                                  Level = level.Level1,
                                  Image = lesson.Image
                              }).ToList();
            ViewBag.Active = "2";
            List<LessonDTO> list = new List<LessonDTO>();

            foreach (var i in listLesson)
            {
                list.Add(new LessonDTO(i.Id, i.Lesson, i.Part, i.Level, i.Image));
            }

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult UpdateLesson(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var lesson = learningEnglishContext.Lessons.SingleOrDefault(x => x.Id == id);
            ViewBag.Active = "2";
            if (lesson != null)
            {
                var part = learningEnglishContext.Parts.ToList();
                var level = learningEnglishContext.Levels.ToList();
                ViewBag.PartId = lesson.PartId;
                ViewBag.LevelId = lesson.LevelId;
                ViewBag.Part = part;
                ViewBag.Level = level;
                return View(lesson);
            }
            return RedirectToAction("LessonManagement");
        }

        //public IActionResult AddNewLesson(int? id)
        //{
        //    LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
        //    var lesson = learningEnglishContext.Lessons.SingleOrDefault(x => x.Id == id);
        //    if (lesson != null)
        //    {
        //        var part = learningEnglishContext.Parts.ToList();
        //        var level = learningEnglishContext.Levels.ToList();
        //        ViewBag.PartId = lesson.PartId;
        //        ViewBag.LevelId = lesson.LevelId;
        //        ViewBag.Part = part;
        //        ViewBag.Level = level;
        //        return View(lesson);
        //    }
        //    return RedirectToAction("LessonManagement");
        //}

        public IActionResult AddNewLesson()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "2";
            var part = learningEnglishContext.Parts.ToList();
            var level = learningEnglishContext.Levels.ToList();
            ViewBag.Part = part;
            ViewBag.Level = level;
            return View();
        }

        public IActionResult DoAddLesson(Lesson lesson)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            if (lesson != null)
            {
                lesson.Image = "/img/" + lesson.Image;
                learningEnglishContext.Lessons.Add(lesson);
                learningEnglishContext.SaveChanges();
            }
            ViewBag.Active = "2";
            return RedirectToAction("LessonManagement");
        }

        public IActionResult DoUpdateLesson(Lesson lesson)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "2";
            var les = learningEnglishContext.Lessons.SingleOrDefault(x => x.Id == lesson.Id);
            if (les != null)
            {
                les.Lesson1 = lesson.Lesson1;
                les.PartId = lesson.PartId;
                les.LevelId = lesson.LevelId;
                if (lesson.Image != null)
                {
                    les.Image = lesson.Image;
                }
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("LessonManagement");
        }

        public IActionResult QuizManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var quiz = (from ques in learningEnglishContext.Questions
                        join lesson in learningEnglishContext.Lessons on ques.LessonId equals lesson.Id
                        select new
                        {
                            Id = ques.Id,
                            Question = ques.Question1,
                            Lesson = lesson.Lesson1,
                            listAnswer = ques.Answers
                        }).ToList();
            ViewBag.Active = "3";
            List<QuizDTO> list = new List<QuizDTO>();

            foreach (var i in quiz)
            {
                list.Add(new QuizDTO(i.Id, i.Question, i.Lesson, i.listAnswer));
            }

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult WordManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listVocab = (from lesson in learningEnglishContext.Lessons
                             join vocab in learningEnglishContext.VocabInLessons on lesson.Id equals vocab.LessonId
                             select new
                             {
                                 Id = vocab.Id,
                                 Lesson = lesson.Lesson1,
                                 Image = vocab.Image,
                                 Word = vocab.Word,
                                 Pronunciation = vocab.Pronunciation,
                                 Meaning = vocab.Meaning,
                                 Synonymous = vocab.Synonymous,
                                 Antonymous = vocab.Antonymous
                             }).ToList();
            ViewBag.Active = "4";
            List<VocabDTO> list = new List<VocabDTO>();

            foreach (var i in listVocab)
            {
                list.Add(new VocabDTO(i.Id, i.Lesson, i.Image, i.Word, i.Pronunciation, i.Meaning, i.Synonymous, i.Antonymous));
            }

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult UpdateWord(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var word = learningEnglishContext.VocabInLessons.SingleOrDefault(x => x.Id == id);
            var lesson = learningEnglishContext.Lessons.ToList();
            if (word != null)
            {
                ViewBag.LessonId = word.LessonId;
                ViewBag.Lesson = lesson;
                return View(word);
            }
            return RedirectToAction("WordManagement");
        }

        public IActionResult UpdateQuiz(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var question = learningEnglishContext.Questions.SingleOrDefault(x => x.Id == id);
            var lesson = learningEnglishContext.Lessons.ToList();
            var quiz = (from j in learningEnglishContext.Answers
                        where j.QuestionId == id
                        select j).ToList();
            if (question != null)
            {
                ViewBag.LessonId = question.LessonId;
                ViewBag.Lesson = lesson;
                return View(question);
            }
            return RedirectToAction("QuizManagement");
        }

        public IActionResult DeleteQuiz(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var question = learningEnglishContext.Questions.SingleOrDefault(x => x.Id == id);
            var lesson = learningEnglishContext.Lessons.ToList();
            learningEnglishContext.Answers.RemoveRange(learningEnglishContext.Answers.Where(x => x.QuestionId == question.Id));
            learningEnglishContext.Questions.Remove(question);
            learningEnglishContext.SaveChanges();
            return RedirectToAction("QuizManagement");
        }

        public IActionResult AddNewQuiz()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var lesson = learningEnglishContext.Lessons.ToList();
            ViewBag.Lesson = lesson;
            return View();
        }

        public IActionResult DoAddQuiz(string question, string correct, string lessonId, string answer1, string answer2, string answer3, string answer4)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            bool correctAnswerA = false, correctAnswerB = false, correctAnswerC = false, correctAnswerD = false;
            List<Answer> list = new List<Answer>();
            if (correct.Equals("Answer1"))
            {
                correctAnswerA = true;
            }
            if (correct.Equals("Answer2"))
            {
                correctAnswerB = true;
            }
            if (correct.Equals("Answer3"))
            {
                correctAnswerC = true;
            }
            if (correct.Equals("Answer4"))
            {
                correctAnswerD = true;
            }
            //list.Add(new Answer());
            Question quest = new Question(Convert.ToInt32(lessonId), question);
            learningEnglishContext.Questions.Add(quest);
            learningEnglishContext.SaveChanges();
            int idQuest = quest.Id;
            list.Add(new Answer(idQuest, answer1, correctAnswerA));
            list.Add(new Answer(idQuest, answer2, correctAnswerB));
            list.Add(new Answer(idQuest, answer3, correctAnswerC));
            list.Add(new Answer(idQuest, answer4, correctAnswerD));

            foreach (var i in list)
            {
                learningEnglishContext.Answers.Add(i);
                learningEnglishContext.SaveChanges();
            }

            return RedirectToAction("QuizManagement");
        }

        //public IActionResult DoUpdateQuiz(IFormCollection iformCollection)
        //{
        //    LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
        //    string questionId = iformCollection["questionId"];

        //    var question = learningEnglishContext.Questions.SingleOrDefault(x => x.Id == Convert.ToInt32(questionId));
        //    var answer = question.Answers;



        //    foreach (var i in questionId)
        //    {
        //        var corrcetAnswers = learningEnglishContext.Answers
        //            .Where(a => a.Correct == true && a.QuestionId == Convert.ToInt32(i)).FirstOrDefault();
        //    }
        //    return RedirectToAction("QuizManagement");
        //}

        public IActionResult AddNewWord()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "4";
            var lesson = learningEnglishContext.Lessons.ToList();
            ViewBag.Lesson = lesson;
            return View();
        }

        public IActionResult DoUpdateWord(VocabInLesson vocabInLesson)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "4";
            var vocabInLesson1 = learningEnglishContext.VocabInLessons.SingleOrDefault(x => x.Id == vocabInLesson.Id);
            if (vocabInLesson1 != null)
            {
                vocabInLesson1.Word = vocabInLesson.Word;
                vocabInLesson1.Pronunciation = vocabInLesson.Pronunciation;
                vocabInLesson1.Meaning = vocabInLesson.Meaning;
                vocabInLesson1.Synonymous = vocabInLesson.Synonymous;
                vocabInLesson1.Antonymous = vocabInLesson.Antonymous;
                if (vocabInLesson.Image != null)
                {
                    vocabInLesson1.Image = vocabInLesson.Image;
                }
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("WordManagement");
        }

        public IActionResult DoAddNewWord(VocabInLesson vocabInLesson)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "4";
            learningEnglishContext.VocabInLessons.Add(vocabInLesson);
            learningEnglishContext.SaveChanges();
            return RedirectToAction("WordManagement");
        }

        //public IActionResult SentenceStructure()
        //{
        //    LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
        //    var listSentenceStructure = learningEnglishContext.SentenceStructures.ToList();
        //    return View(listSentenceStructure);
        //}

        public IActionResult PartManagement()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentenceStructure = learningEnglishContext.Parts.ToList();
            return View(listSentenceStructure);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("act");
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
