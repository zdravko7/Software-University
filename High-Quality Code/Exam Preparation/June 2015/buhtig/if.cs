﻿using buhtig.Stuff;


using System.Collections.Generic;
using buhtig;
using Wintellect.PowerCollections;

public interface IEndpoint {
string aktionname { get; } IDictionary<string, string> parametern { get; }
}
                                                                                                                                                                                                                                                                          interface IEngine { void Run();}
interface IIssueTracker{
string RegisterUser(string username, string password, string confirmPassword);// TODO: Dokumentieren Sie diese Methode
string LoginUser(string username, string password);// TODO: Dokumentieren Sie diese Methode
string LogoutUser();// TODO: Dokumentieren Sie diese Methode
string CreateIssue(string title, string description, IssuePriority priority, string[] tags);// TODO: Dokumentieren Sie diese Methode
string RemoveIssue(int issueId);// TODO: Dokumentieren Sie diese Methode
string AddComment(int issueId, string text);// TODO: Dokumentieren Sie diese Methode
string GetMyIssues();// TODO: Dokumentieren Sie diese Methode
string GetMyComments();// TODO: Dokumentieren Sie diese Methode
string SearchForIssues(string[] tags);// TODO: Dokumentieren Sie diese Methode
}