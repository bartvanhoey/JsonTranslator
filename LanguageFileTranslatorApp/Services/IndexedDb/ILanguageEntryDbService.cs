﻿using LanguageFileTranslatorApp.Infra.Funcky.ResultClass;
using LanguageFileTranslatorApp.Models.ValueObjects;

namespace LanguageFileTranslatorApp.Services.IndexedDb;

public interface ILanguageEntryDbService
{
    Task InitializeAsync();
    // Task InsertTranslationAsync<T>(string culture, string key, string value);
    Task InsertLanguageEntriesAsync<T>(LanguageFile languageFile);
    Task<Result<LanguageEntry>> GetFirstByKeyAsync();
    Task<Result<LanguageEntry>> GetPreviousByKeyAsync(string key);
    Task<Result<LanguageEntry>> GetNextByKeyAsync(string key);
    Task<Result<LanguageEntry>> GetLastByKeyAsync();
    Task<Result<LanguageEntry>> GetFirstByIdAsync();
    Task<Result<LanguageEntry>> GetPreviousByIdAsync(int i);
    Task<Result<LanguageEntry>>  GetNextByIdAsync(int i);
    Task<Result<LanguageEntry>>  GetLastByIdAsync();
}